using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RedRunner.Characters;

namespace RedRunner.Collectables
{
    public class ShopScript : Collectable
    {
        [SerializeField]
        protected ParticleSystem m_ParticleSystem;
        [SerializeField]
        protected SpriteRenderer m_SpriteRenderer;
        [SerializeField]
        protected Collider2D m_Collider2D;
        [SerializeField]
        protected Animator m_Animator;
        [SerializeField]
        protected bool m_UseOnTriggerEnter2D = true;

        public override SpriteRenderer SpriteRenderer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Collider2D Collider2D
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override Animator Animator
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool UseOnTriggerEnter2D
        {
            get { throw new NotImplementedException(); }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void buyDoubleJump()
        {
            GameManager.Singleton.m_Coin.Value--;
            m_Animator.SetTrigger(COLLECT_TRIGGER);
            m_ParticleSystem.Play();
            m_SpriteRenderer.enabled = false;
            m_Collider2D.enabled = false;
            Destroy(gameObject, m_ParticleSystem.main.duration);
            AudioManager.Singleton.PlayCoinSound(transform.position);
        }

        public override void Collect()
        {
            GameManager.Singleton.m_Coin.Value++;
            m_Animator.SetTrigger(COLLECT_TRIGGER);
            m_ParticleSystem.Play();
            m_SpriteRenderer.enabled = false;
            m_Collider2D.enabled = false;
            Destroy(gameObject, m_ParticleSystem.main.duration);
            AudioManager.Singleton.PlayCoinSound(transform.position);
        }

        public override void OnCollisionEnter2D(Collision2D collision2D)
        {
            throw new NotImplementedException();
        }

        public override void OnTriggerEnter2D(Collider2D other)
        {
            throw new NotImplementedException();
        }
    }
}