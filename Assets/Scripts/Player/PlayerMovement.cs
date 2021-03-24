using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float Speed = 0.3f;
    public GameObject MainCamera;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    public LayerMask GroundLayer = 1; // 1 == "Default"
    private CapsuleCollider _collider;
    public float JumpForce = 1f;
    [SerializeField] private GameObject _mine; // Наша мина
    [SerializeField] private Transform _mineSpawnPlace; // точка, где создается 
    [SerializeField] float _health = 100f;
    [SerializeField] int jumpUpdate = 1;
    [SerializeField] int speedUpdate = 1;
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _d1;
    [SerializeField] private float boostTime = 50f;
    [SerializeField] private float _time;
    [SerializeField] private float _timeDuration;
    [SerializeField] private bool boost = false;
    [SerializeField] public bool isPaused = false;
    
    public GameObject myObject;
    //[SerializeField] HealthBar value;
    void Start ()
    {
        _collider = GetComponent<CapsuleCollider>();
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
        HealthBar.SetHealthBarValue(_health);
       // GetComponent<HealthBar> ();
    }

    void FixedUpdate ()
    {
        _time = Time.fixedDeltaTime;
        while(boost == true && boostTime < 1000)
            {
            boostTime = boostTime + _time;
            if(boostTime >= 1000)
            {
                boost = false;
                Speed = 2;
                boostTime = 0f;
            }
            
        }
        HealthBar.SetHealthBarValue(_health);
        PauseLogic();
        getMine();
        JumpLogic();
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        float angle = turnSpeed * horizontal * Time.fixedDeltaTime;
        
        m_Movement.Set(0f, 0f, vertical);
        m_Movement.Normalize ();
        m_Movement = transform.rotation * m_Movement; 


        bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        //bool isJump = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool ("IsWalking", isWalking);

        
        //Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.fixedDeltaTime, 0f);
        m_Rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + angle, 0);

    }

    void OnAnimatorMove ()
    {
        m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude * Speed);
        m_Rigidbody.MoveRotation (m_Rotation);
    }

    private bool _isGrounded
    {
        get {
            var bottomCenterPoint = new Vector3(_collider.bounds.center.x, _collider.bounds.min.y, _collider.bounds.center.z);


            return Physics.CheckCapsule(_collider.bounds.center, bottomCenterPoint, _collider.bounds.size.x / 2 * 0.9f, GroundLayer);
            
        }
    }

    private void JumpLogic()
    {
        if (_isGrounded && (Input.GetAxis("Jump") > 0))
        {
            
            m_Rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        
        
    }

    private void getMine()
    {
        if (Input.GetButtonDown("Fire1"))   
        {                      
         Instantiate(_mine, _mineSpawnPlace.position, _mineSpawnPlace.rotation);   // Создаем _mine в точке _mineSpawnPlace
        
        }
    }

    public void Heal(int _heal)
    {
        print("mmm: " + _heal);

        _health += _heal;


    }

    public void Hurt(int damage)
    {
        print("Ouch: " + damage);

        _health -= damage;

        if (_health <= 0)
        {
            gameObject.SetActive(false);
            myObject.SetActive(true);

        }
    }
    
    public void JumpBoost(float jumpUpdate)
    {
        _time = Time.fixedDeltaTime;
        
        Speed = Speed * jumpUpdate;
        boost = true;
        return;
 
    }

    public void SpeedBoost(int speedUpdate)
    {

    }

    private void PauseLogic() {
        if (Input.GetKey("escape"))
        {
            gameObject.SetActive(false);
            myObject.SetActive(true);
            Time.timeScale = 0;
          
        }


    }
}