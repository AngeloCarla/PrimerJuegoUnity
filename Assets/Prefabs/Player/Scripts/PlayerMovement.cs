using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    private IMovementStrategy strategy;
    private Player player;

    void Start()
    {
        forceToApply = new Vector3(0, 0, 300);
        // forceToApply = new Vector3(0, 0, 10);
        timeSinceLastForce = 0f;
        intervalTime = 2f;

        player = new Player(5f, 5f);
        //SetStrategy(new SmoothMovementStrategy());
        //SetStrategy(new AcelerateMovementStrategy());
    }

    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce > intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply);
            // gameObject.GetComponent<Rigidbody>().AddForce(forceToApply, ForceMode.Impulse);
            timeSinceLastForce = 0f;
        }
    }
    public void MovePlayer(float input)
    {
        strategy.Move(transform, player, input);
    }
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }
}
