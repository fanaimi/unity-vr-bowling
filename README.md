# unity-vr-bowling

* XR INTERACTION TOOLKIT
	* "com.unity.xr.interaction.toolkit": "1.0.0-pre.8"
	* import "Default Input Actions" and "XR device simulator"
	
* XR PLUG-IN MANAGEMENT
 
	Project settings > XR plugin management > PC> oculus and Windows mixed reality
 
	Project settings > XR plugin management > ANDROID > oculus 
 
* delete main camera
 
* XR > (Room Scale) XR Rig
 
* watch this video! https://www.youtube.com/watch?v=EWHOSbUIEwk&t=201s&ab_channel=SharkJets
 
* follow these steps:
	* on XR-rig > add component > Input Action Manager  
	* under Input Action Manager > Action assets >  size: 1 - Element 0: XRI Default Input Actions 
	* LeftHand Controller > remove component "XR Controller"
	* under Assets > samples > XR Interaction toolkit > v.v.v > Default Input actions, drag "" into LeftHand Controller
	* repeat for RightHand Controller
	
* for the ball:
	* sphere collider
	* rigidbody
	* XR Grab Interactable
	
* for Hands:
	* remove "XR Ray Interactor", "XR Ray Interactor Line Visual" and "Line Renderer" 
	* add component "XR DIrect Interactor"