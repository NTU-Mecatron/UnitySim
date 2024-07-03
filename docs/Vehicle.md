## Adding a vehicle to the scene

Step 1: Assets -> Models -> vehicle. Drag and drop the vehicle prefab into the scene. The prefab would already have a camera object.

Step 2: In the Hierarchy, select the Ocean object. In the Inspector, drag the camera component of the vehicle to the Camera and Viewpoint fields of the Crest Ocean Renderer object.

Step 3: Check to make sure that this camera has "Crest Underwater Renderer" script. Adjust the Depth Fog Density Factor to a value that suits the scene.

Step 4: Remove or deactivate all other cameras in the scene.