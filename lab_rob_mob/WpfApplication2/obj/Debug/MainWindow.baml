   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5          � Title$  
MainWindow��5   	   $��332.427��6   $	��603��6-   .��5	      � -   5        $��	0,0,-8,-1q�5	   "    � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $
��172* �6   .+�5   
   � $��2,10,205,88q�6   $��1��6$   .+�5      �� -   5         ��Name$ textBox1��5      $
��Left=�6(   $��23��6C   $��0,26,0,0q�6O    �� TextWrapping$
 Wrap=�6a   $��192.168.2.34��6u   $	��Top=�6�   $	��120��6�   6�   �� 5      -   5        $ textBox2��5      $
��Left=�6(   $��23��6C   $��0,71,0,0q�6O   $
 Wrap=�6a   $
��8000��6u   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ textBox3��5      $
��Left=�6(   $��23��6C   $��	0,120,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��212��6�    �� 
IsReadOnly . 6�   �� 5      -   5         ��Name$ Connect��5      $��Connect��6&   $
��Left=�68   $��
137,29,0,0q�6S   $	��Top=�6g   $��75��6   6�   �� 5      -   5        $ 
Disconnect��5      $��
Disconnect��6)   $
��Left=�6>   $��
137,74,0,0q�6Y   $	��Top=�6m   $��75��6�    J� RenderTransformOrigin$ 
1.2,-0.409&�6�   �� 5      -   5         ��Name$ label��5      $	��IP:��6#   $
��Left=�61   $	��Top=�6L   �� 5      -	   5        $ 
label_Copy��5      $��Port:��6(   $
��Left=�68   $��0,49,0,0q�6S   $	��Top=�6e   $ 4.105,7.085&�6}   �� 5      -
   5        $ label_Copy1��5      $��Ramka odebrana:��6)   $
��Left=�6C   $��0,94,0,0q�6^   $	��Top=�6p   $ 4.105,7.085&�6�   �� 5      -   5        $ textBox4��5      $
��Left=�6(   $��23��6C   $��	0,169,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��212��6�   $ 	0.5,3.333&�6�    . 6�   �� 5      -   5        $ label_Copy2��5      $��Ramka wysłana:��6)   $
��Left=�6B   $��	0,143,0,0q�6]   $	��Top=�6p   $ 4.105,7.085&�6�   �� 5      -   5         ��Name$ image��5      $
��Left=�6$   $	��216��6?   $��256,10,-189,-22q�6L   $	��Top=�6e   $	��319��6}   $]��WG:\lab_roboty_mobilne_final\lab_rob_mob\WpfApplication2\Resources\lab_rob_mob_instr.bmp��6�   5      �� 5   
   -   5        	 ��Name$	 
Klawiatura��5      $��
Klawiatura��6'   $
��Left=�6<   $��	2,216,0,0q�6W   $	��Top=�6j   $ 0.712,-0.736&�6�   $��1��6�   $��15��6�   $��75��6  �� 5   
   -   5        $ textBox_status��5      $��1��6*   $
��Left=�6:   $��23��6U   $��
55,247,0,0q�6a   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ label1��5      $��Status:��6    $��1��62   $
��Left=�6B   $��	0,244,0,0q�6]   $	��Top=�6p   $��50��6�   5       5!      