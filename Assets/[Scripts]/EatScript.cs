using UnityEngine;

public class EatScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            // Try to get the FoodData component from the object we hit
            FoodData food = other.gameObject.GetComponent<FoodData>();

            // If it doesn't have the script, add one dynamically as a backup so it doesn't error
            if (food == null)
            {
                food = other.gameObject.AddComponent<FoodData>();
            }

            // Register the bite
            food.TakeBite();

            // Play your effects for EVERY bite taken
            PlayEatSoundEffect();
            CreateFoodCrumbs();

            // Only destroy the object if it is completely eaten
            if (food.bitesRemaining <= 0)
            {
                Debug.Log("Food completely consumed. Destroying object.");
                DestroyFood(other.gameObject);
            }
            else
            {
                Debug.Log($"Took a bite! Bites left: {food.bitesRemaining}");
            }
        }
    }

    private void PlayEatSoundEffect()
    {
        float RandomSoundPitchValue = Random.Range(0.8f, 1.2f);

        _audioSource.pitch = RandomSoundPitchValue;
        _audioSource.Play();
    }

    private void CreateFoodCrumbs()
    {
        particleFoodCrumbs.Play();
    }

    private void DestroyFood(GameObject food)
    {
        Destroy(food);
    }


    #region Setup
    private AudioSource _audioSource;

    public ParticleSystem particleFoodCrumbs;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        _audioSource.clip = AudioLibrary.Instance.EatFood;
    }

    #endregion
}