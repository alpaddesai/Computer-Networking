   M S B A M L   `   `   `  ����M  IComputerNetworking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ComputerNetworkingComputerNetworking  5   	       ComputerNetworking.I2Cbus   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ComputerNetworking     5   	     � Title$  I2Cbus��5   	   $	��550��6   $	��862��6%   $	��838��61   $	��550��6@   .��5	      � $��	0,0,24,13q�6   $	��806��6   $	��506��6-    � RowDefinitions 5
   
   �� 5      $
��254* �6   �� 5      $
��257* �6    � ColumnDefinitions 5   
   �� 5      $
��101* �6   �� 5      $
��721* �6   .+�5   
   �� -   5        $
��Left=�5      $	��232��61   $��	30,10,0,0q�6>   $	��Top=�6Q   $	��772��6i   $��2��6�   . �5      /� .T�5      J� .*�6   .*�5      �� $
��Bold"�6   $�Data Rate:  ��6,    �� 5      $ �100, 400 kb/s ,1, 3.4Mb/s ��6   5      J� 5      .*�6   .*�5      ��  �� 5      $
��Bold"�6   $�Advantages:  ��6,    �� 5      $��Simple , master - slave access methodology, single access at a time.  Separate data (SDA) and clock (SCL) lines. Only two pins.��6   5      J� 5      .*�6   .*�5      �� $
��Bold"�6   $�Variations: ��6,    �� 5      $a�[The SMBus, PMBus, AVSBus are all variations of the I2C interface with protocol differences.��6   5       J� 5!      .*�6   .*�5"      �� $
��Bold"�6   $�
PCB traces��6,    �� 5#      $���: The SDA and SCL lines are pulled up by pull up resistors (determined by the # of capacitance i.e connections to the I2C bus) to the power supply and are shared amongst the various devices starting form the microcontroller or processor to IO expanders, EEPRom, LCD Driver sensors and other devices on the board.  Since it's an open drain connection, the output when active can pull the bus down.    Each device has a 7 bit address whose upper 4 bits are device specific and encoded within the device. The next 3 bits are address bits and are hard-wired on the board.     Each peripheral device decodes the address byte sent by the microcontroller to determine if it is the target of the transmission, removing the need for an individual chip select line.��6   5$      J� 5%      .*�6   .*�5&      �� $X�RReference: Microcontrollers, 2nd Edition by Bryan A Jones, JW. Bruce, Robert Reese��6   5'      5(      5)      �� 5*   
   $��2��6   $��
32,1,28,-4q�6$   $��
Image2.png��68   $
��Fill=�6L   $��1��6[   5,      5-      