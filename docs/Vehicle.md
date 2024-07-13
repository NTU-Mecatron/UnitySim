## Adding a vehicle to the scene

1. Assets -> Models -> vehicle. Drag and drop the vehicle prefab into the scene. The prefab would already have a camera object.

2. : In the Hierarchy, select the Ocean object. In the Inspector, drag the camera component of the vehicle to the Camera and Viewpoint fields of the Crest Ocean Renderer object.

3. Check to make sure that this camera has "Crest Underwater Renderer" script. Adjust the Depth Fog Density Factor to a value that suits the scene.

4. Remove or deactivate all other cameras in the scene.

## Adding Imu sensor

1. Right click on Vehicle -> Create Empty to add a child to the object. Rename the object to "Imu".

2. Add Component -> Imu ROS_modified. Change the Imu topic and publishing frequency appropriately. It is recommended to set the publishing frequency lower than the sample frequency.

3. To prevent the console from logging "No noise instance" error, select "Gaussian" as the noise type for all Acceleration, Angular Velocity, and Orientation Noise.

The published Imu message has already been translated into the North-East-Down (NED) coordinate frame convention, not the Unity convention.