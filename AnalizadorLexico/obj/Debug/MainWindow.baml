   M S B A M L   `   `   `  ����K  GAnalizadorLexico, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AnalizadorLexicoAnalizadorLexico  5   	   !    AnalizadorLexico.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AnalizadorLexico     5   	     � Title$  ANALIZADOR LÉXICO��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � -   5         �Name$ ANALIZADOR_LEXICO��5	      .+�5
   
   �� -   5         ��Name$ btn_ingresar��5
      $��INGRESAR��6'   $
��Left=�6:   $��342,330,0,0q�6U   $	��Top=�6j   $	��158��6�   $��30��6�   6�   �� 5   
   -   5         ��Name$ 
txt_cadena��5      $
��Left=�6&   $��59��6A   $��169,252,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��481��6�   $��Mongolian Baiti)�6�   $��18(�6�   �� 5   
   -   5         ��Name$ listV_palabra��5      $
��Left=�6*   $	��160��6E   $��
141,60,0,0q�6R   $	��Top=�6f   $	��130��6~    �� View 5      �� 5      .P�5      �� $��PALABRAS��6%    �� Width$	 125��67   5      5      �� 5   
   -   5        $ listV_numEntero��5      $
��Left=�6,   $	��160��6G   $��
271,60,0,0q�6T   $	��Top=�6h   $	��130��6�    5      �� 5      .P�5      �� $��NUMEROS ENTEROS��6%   $	 125��6>   5      5      �� 5   
   -   5        $ listV_numDecimal��5      $
��Left=�6-   $	��160��6H   $��
401,60,0,0q�6U   $	��Top=�6i   $	��130��6�    5      �� 5      .P�5      �� $��NUMEROS DECIMALES��6%   $	 125��6@   5      5       �� 5!   
   -   5        $ listV_moneda��5!      $
��Left=�6)   $	��160��6D   $��
531,60,0,0q�6Q   $	��Top=�6e   $	��130��6}    5"      �� 5#      .P�5$      �� $��MONEDA��6%   $	 125��65   5%      5'      5)      5*      