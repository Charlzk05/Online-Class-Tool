   M S B A M L   `   `   `  ����J  FOnlineClassTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OnlineClassToolOnlineClassTool  5   	        OnlineClassTool.TextEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:OnlineClassTool     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  Text Editor Window��5	   	   $	��600��6$   $
��1000��61    � WindowStartupLocation$ CenterScreen=�6>   .��5
      �� $��5,0,5,5q�6   ._�5   
   ]� ��.  .+�5      o� $	��Top=�6   ��6(   Z� .@�5      m� $
��Edit��6   .@�5      m� $��	Font Size��6   .@�5      m� -   5         m�Name$ MFS10��5   #   $
��10px��6F   $
��10px(�6T   m� 5      -   5        $ MFS12��5   #   $
��12px��6F   $
��12px(�6T    m� InputGestureText$ Default��6d   m� 5      -   5        $ MFS14��5   #   $
��14px��6F   $
��14px(�6T   m� 5      -   5        $ MFS16��5   #   $
��16px��6F   $
��16px(�6T   m� 5      -   5        $ MFS18��5   #   $
��18px��6F   $
��18px(�6T   m� 5      -   5        $ MFS20��5   #   $
��20px��6F   $
��20px(�6T   �� 5      m� 5      -   5        $ MFS22��5   #   $
��22px��6F   $
��22px(�6T   m� 5      -   5        $ MFS24��5   #   $
��24px��6F   $
��24px(�6T   m� 5      -	   5        $ MFS26��5   #   $
��26px��6F   $
��26px(�6T   m� 5      -
   5        $ MFS28��5   #   $
��28px��6F   $
��28px(�6T   m� 5      -   5        $ MFS30��5   #   $
��30px��6F   $
��30px(�6T   5      m� 5      $��Font Family��6   .@�5      m� -   5        $ 
FFConsolas��5   #   $��Consolas��6P   $��Consolas)�6b   $ Default��6x   m� 5      -   5        $ 	FFSegeoUI��5   #   $��Segeo UI��6N   $��Segeo UI)�6`   m� 5      -   5        $ FFArial��5   #   $��Arial��6J   $��Arial)�6Y   m� 5       -   5        $ FFBahnschrift��5    #   $��Bahnschrift��6V   $��Bahnschrift)�6k   m� 5!      -   5        $ FFYuGothicUI��5!   #   $��Yu Gothic UI��6T   $��Yu Gothic UI)�6j   m� 5"      -   5        $ 	FFVerdana��5"   #   $��Verdana��6N   $��Verdana)�6_   5#      m� 5$      $��Font Weight��6   .@�5%      m� -   5        $ FWUltraLight��5%   #   $��Ultra Light��6T   $��
UltraLight"�6i   m� 5&      -   5        $ FWLight��5&   #   $��Light��6J   $��Light"�6Y   �� 5'      m� 5(      -   5        $ FWNormal��5(   #   $��Normal��6L   $��Normal"�6\   $ Default��6p   m� 5)      -   5        $ FWMedium��5)   #   $��Medium��6L   $��Medium"�6\   �� 5*      m� 5+      -   5        $ 
FWSemiBold��5+   #   $��	Semi Bold��6P   $��SemiBold"�6c   m� 5,      -   5        $ FWBold��5,   #   $
��Bold��6H   $
��Bold"�6V   �� 5-      m� 5.      -   5        $ FWUltraBold��5.   #   $��
Ultra Bold��6R   $��	UltraBold"�6f   m� 5/      -   5        $ FWBlack��5/   #   $��Black��6J   $��Black"�6Y   �� 50      m� 51      -   5        $ FWHeavy��51   #   $��Heavy��6J   $��Heavy"�6Y   m� 52      -   5        $ FWUltraBlack��52   #   $��Ultra Black��6T   $��
UltraBlack"�6i   53      54      55      � 56      $��24��6   $	��Top=�6   $��0,5,0,0q�64    � ColumnDefinitions 57      �� 58      $
��Auto �6'   �� 59      $
��Auto �6'   �� 5:      $
��Auto �6'   .+�5<      �� -   5         ��Name$ btnSaveFile��5<      $��0��6H   $��0q�6n   ��6X   Z� .��5=      "  FontAwesome.WPF.ImageAwesome     Icon$
 Save=�6&   $��2,2,2,2q�62    � 	Resources 5>       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 5?      " ��6    .�5@      �� 	 �@��CornerRadius$
 3��6=   5A      5B      5C      �� 5D      -   5        $ btnOpenFile��5D      $��1��6H   $��3,0,0,0q�6X   $��0q�6   ��6i   Z� .��5E        $ PencilSquare=�6&   $��2,2,2,2q�6:    5F      ��%^   '��       �� 5G      " ��6    .�5H      �� 	 �@��CornerRadius$
 3��6=   5I      5J      5K      5L      �� 5M      -   5         ��Name$ rTextBox��5M      $��Consolas)�6,   $��0,5,0,0q�6B   $��0,3,0,3q�6S   $ �� HorizontalScrollBarVisibility$
 Auto=�6e   " �� VerticalScrollBarVisibility$
 Auto=�6�   5N      5O      5P      