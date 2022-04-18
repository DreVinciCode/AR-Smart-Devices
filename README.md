# AR-Smart-Devices
The goal of this project is to toggle an electronic device on/off using an AR device.


Issues when importing ROS-Sharp: https://github.com/siemens/ros-sharp/issues/425

Current Solution: https://github.com/siemens/ros-sharp/issues/310
Thanks to Unity's community I was able to find a solution, but I think it is the Unity's bug.

The solution to this particular problem is to manually add the "com.unity.nuget.newtonsoft-json": "2.0.0" to the manifest.json file since Unity doesn't do it automatically. The manifest.json file is located under the Project folder\Packages. Then you can safely delete the Newtonsoft.Json.dll from the Assets\RosSharp\Plugins\External folder and use the Unity's implementation. The Newtonsoft.Bson.Json.dll no longer complains about lack of Newtonsoft.Json.dll.

I think this is Unity's problem because for every other package that is shown in the Package manager there is an entry in the manifest.json, but for these "hidden" packages used in some of the global ones there is no entry in the manifest.json and because of that other .dll will no see it and thus there was an error in the Newtonsoft.Bson.Json.dll.

However, since Unity didn't implement specific package for System.Runtime.CompilerServices.Unsafe.dll the same cannot be done for that specific .dll but I will notify them about the issue.


Connecting multiple arduinos to one machine:

Make the adjustments to rosserial_python serial_node.py
rospy.init_node("serial_node", anonymous=True) rospy.loginfo("ROS Serial Python Node {}".format(rospy.get_caller_id()))