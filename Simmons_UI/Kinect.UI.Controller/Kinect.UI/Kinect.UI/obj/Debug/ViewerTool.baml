   M S B A M L   `   `   `  ����^  ZMicrosoft.Samples.Kinect.WpfViewers, Version=1.7.0.0, Culture=neutral, PublicKeyToken=null�^clr-namespace:Microsoft.Samples.Kinect.WpfViewers;assembly=Microsoft.Samples.Kinect.WpfViewers#Microsoft.Samples.Kinect.WpfViewers  5   	    	Kinect.UI   Kinect.UI.ViewerTool   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   mkv^clr-namespace:Microsoft.Samples.Kinect.WpfViewers;assembly=Microsoft.Samples.Kinect.WpfViewers     5   	   -   5          � Title$  
ViewerTool��5   	   $	��213��5   	   $	��284��5   	    J� Opacity$	 0.5Q�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5
   	    � ShowInTaskbar .   � Topmost . {�.  .��5      � -   5         �Name$ grid0��5      $
��Left=�6   $	��Top=�65   .+�5   
   � -   5        $ grid1��5      $
��Left=�6   $	��Top=�69   $	��284��6Q   $	��213��6]   .+�5      ;   5Microsoft.Samples.Kinect.WpfViewers.KinectDepthViewer  -   5          Name$ DepthViewer��5   #   $
��Left=�6l   $	��Top=�6�   7   1Microsoft.Samples.Kinect.WpfViewers.KinectControl   KinectSensorManager 68   �� *KinectSensorManager+6�   �� 5      .+�5      >   8Microsoft.Samples.Kinect.WpfViewers.KinectSkeletonViewer  -   5        $	��284��5   %   $	��213��5   %   	   	ShowBones	 . 
   
ShowJoints
 .    
ShowCenter .    	ImageType$ Depth=�5   %    5   %   �� *KinectSensorManager+5   7   5      5      5      5      