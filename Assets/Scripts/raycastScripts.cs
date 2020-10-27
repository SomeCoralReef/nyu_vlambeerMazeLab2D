using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastScripts : MonoBehaviour
{

    public GameObject skinPreFab;
    // Update is called once per frame
    void Update()
    {
        Ray2D myleftRay = new Ray2D(transform.position,Vector2.left);
        Ray2D myrightRay = new Ray2D(transform.position,Vector2.right);
        Ray2D myupRay = new Ray2D(transform.position,Vector2.up);
        Ray2D mydownRay = new Ray2D(transform.position,Vector2.down);
        float maxRayDist = 0.6f;
        RaycastHit2D myleftRayHit = Physics2D.Raycast(myleftRay.origin,myleftRay.direction,maxRayDist);
        RaycastHit2D myrightRayHit = Physics2D.Raycast(myrightRay.origin,myrightRay.direction,maxRayDist);
        RaycastHit2D myupRayHit = Physics2D.Raycast(myupRay.origin,myupRay.direction,maxRayDist);
        RaycastHit2D mydownRayHit = Physics2D.Raycast(mydownRay.origin,mydownRay.direction,maxRayDist);
        if(mydownRayHit.collider == null){
            Instantiate(skinPreFab, transform.position + new Vector3 (0f,-1f,5f), this.transform.rotation);
        }
        if(myupRayHit.collider == null){
            Instantiate(skinPreFab, transform.position + new Vector3 (0f,1f,5f), this.transform.rotation);

        }
        if(myrightRayHit.collider == null){
            Instantiate(skinPreFab, transform.position + new Vector3 (1f,0f,5f), this.transform.rotation);

        }
        if(myleftRayHit.collider == null){
            Instantiate(skinPreFab, transform.position + new Vector3 (-1f,0f,5f), this.transform.rotation);

        }
    }
}
