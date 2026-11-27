using UnityEngine;

public class PersonajeControl : MonoBehaviour
{
    public Animator animator;
    public void Bailar()  { animator.SetTrigger("bailar"); }
    public void Saludar() { animator.SetTrigger("saludar"); }
}