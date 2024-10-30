using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Pelaajan sijainti, johon kamera kohdistuu
    public float followSpeed = 5f;  // Kameran seuraamisnopeus
    public Vector3 offset;  // Kameran sijainnin offset pelaajaan nähden

    void LateUpdate()
    {
        // Haluttu kameran sijainti pelaajan nykyisen sijainnin ja offsetin mukaan
        Vector3 targetPosition = player.position + offset;

        // Kamera liikkuu kohti kohdesijaintia sulavasti
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Kamera katsoo aina pelaajaa kohti
        transform.LookAt(player);
    }
}
