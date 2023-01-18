using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace HyperCasual.Game
{
    public class Pooler : MonoBehaviour
    {
        [Serializable]
        public struct Pool
        {
            public string Key;
            public GameObject Element;
            public int Count;
        }

        [SerializeField] private Pool[] Pools;
        
        private Dictionary<string, List<GameObject>> m_Pools = new Dictionary<string, List<GameObject>>();
        
        public static Pooler Instance { get; private set; }

        private void Awake()
        {
            Instance = this;

            foreach(Pool pool in Pools)
            {
                CreatePool(pool);
            }
        }

        public void CreatePool(Pool pool)
        {
            List<GameObject> elements = new List<GameObject>();
            Transform poolParent = new GameObject(pool.Key).transform;
            poolParent.SetParent(transform);
            int count = pool.Count;

            while (count > 0)
            {
                elements.Add(CreateElement(pool.Element, poolParent));
                count--;
            }

            m_Pools.Add(pool.Key, elements);
        }

        private GameObject CreateElement(GameObject prefab, Transform parent)
        {
            GameObject element = Instantiate(prefab, parent);
            element.SetActive(false);

            return element;
        }

        public GameObject GetElement(string poolKey, bool active = true)
        {
            List<GameObject> pool = m_Pools[poolKey];
            GameObject element = pool.FirstOrDefault(x => !x.activeInHierarchy);
            if(element == null)
            {
                Pool poolInfo = Array.Find(Pools, x => x.Key == poolKey);
                element = CreateElement(poolInfo.Element, transform.Find(poolKey));
                pool.Add(element);
            }

            element.SetActive(active);
            return element;
        }
    }
}
