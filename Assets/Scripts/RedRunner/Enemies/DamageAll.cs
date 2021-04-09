using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RedRunner.Characters;

namespace RedRunner.Enemies
{

	public class DamageAll : Enemy
	{

		[SerializeField]
		private Collider2D m_Collider2D;
		[SerializeField]
		private FixedJoint2D m_FixedJoint2D;

		public override Collider2D Collider2D {
			get {
				return m_Collider2D;
			}
		}

		void OnCollisionStay2D (Collision2D collision2D)
		{
			Character character = collision2D.collider.GetComponent<Character> ();
			Kill (character);
		}

		public override void Kill (Character target)
		{
            if (null != target)
            {
                target.Die(true);
                m_FixedJoint2D.connectedBody = target.GetComponent<Skeleton>().Body;
            }
			AudioManager.Singleton.PlaySpikeSound (transform.position);
		}

	}

}