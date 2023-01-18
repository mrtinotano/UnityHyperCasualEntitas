using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas.Unity;
using Entitas;

namespace HyperCasual.View
{
    public abstract class UnityView<T> : MonoBehaviour where T : IEntity
    {
        public virtual void Link(T entity) => gameObject.Link(entity);
        public virtual void Unlink() => gameObject.Unlink();

        protected T GetLinkedEntity() => (T)gameObject.GetEntityLink().entity;
    }
}
