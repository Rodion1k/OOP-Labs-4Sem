   M S B A M L   `   `   `  ���� D  @GameStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GameStore	GameStore      GameStore.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:GameStore     $	��500��$	��900��$	��500��$	��900��  � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 	Resources    SearchTextBox �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%N   &	        �� " ��.���  � �� �� " ��.R��� $ 15��
������ .���  � ShowGridLines .   WindowStyle#���  	 � RowDefinitions	 �� $��30 ��� .+�� -   $��WindowToolBar��$��0��
������ .+��� 
 �� Orientation$
 
Horizontal=�$��Right=�.+��� -   $��	MinButton��$��icons/window-minimize.png��$��5q�$��30��$��20��  ToolButtonImage#��[ �� -   $��	MaxButton��$��icons/window-maximize.png��$��5,5,5,5q�$��30��$��20��#��[ �� -   $��CloseButton��$��icons/window-close.png��$��5q�$��30��$��20��#��[ � $��1�� .  � ColumnDefinitions �� $	��200 ��� 	 �� $��70 ��� .+��� $��0��$��0��$8��2Images/epic_games_alt_macos_bigsur_icon_190199.png��$��70��$��70��$��Center=�$��Bottom=��� $��0��$��1��#��[  $��Search��
�������� $��1��$��0��	 �� �� $
��Auto �.+��� $��0��$
 Vertical=�.+��� -   $��
ShopButton��$	��200��$��50�����#04293A  
ShopButton#���    
MenuButton#���  
��������� -   $��GamesButton��$	��200��$��50�����#04293A  GamesButton#���    MenuButtonBehavior#���  
��������� $��1��$
 
Horizontal=�$��Bottom=�$��30��.+��� -   $��ChangeThemeButton��$ ��Icons/theme-light-dark.png���� -   $��LangRuButton��$��Ru��$��5,0,5,0q�$��30��
������ 
�������
������ �� -	   $��LangEnButton��$��En��$��30��
������ 
�������
������  � -
     �Name$ 	MainFrame��$��1��$��1��