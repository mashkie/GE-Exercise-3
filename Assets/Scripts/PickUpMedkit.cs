using System;
using UnityEngine;

public class PickUpMedkit : MonoBehaviour
{
    public AudioSource source;
    public ParticleSystem heartAnimation;

    private GameObject _player = null;
    private PlayerInteraction _playerInteraction;
    private PlayerHealth _playerHealth;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _player = other.gameObject;
            _playerInteraction = other.gameObject.GetComponent<PlayerInteraction>();
            _playerHealth = other.gameObject.GetComponent<PlayerHealth>();

            //if (Input.GetKey(KeyCode.E))
            //{
            //    source.Play();
            //    heartAnimation.Play();

            //    Debug.Log("AAAAA");
            //    _playerHealth.Heal(50);
            //    Debug.Log(_playerHealth.currentHealth);
            //    _playerInteraction.pickUpText.SetActive(false);

            //    Destroy(gameObject, 2f);
            //}
        }
    }

    private void Update()
    {
        if (_player != null && Input.GetKeyDown(KeyCode.E))
        {
            source.Play();
            heartAnimation.Play();

            _playerHealth.Heal(50);
            _playerInteraction.pickUpText.SetActive(false);
            _player = null;

            Destroy(gameObject, 2f);
        }
    }
}