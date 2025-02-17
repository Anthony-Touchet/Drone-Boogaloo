﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDroneMovement : MonoBehaviour
{    
    public float m_moveSpeed = 1;
    public float m_turnSpeed = 1;

    [SerializeField] RotationToInput m_rotationToInput;

    void Update()
    {
        Vector3 rot = m_rotationToInput.InputValues;
        
        var moveZ = rot.z;
        var moveY = rot.x;
        
        Vector3 move = new Vector3(0, 0, moveZ);
        Vector3 turn = new Vector3(0, moveY, 0);

        transform.Translate(move * m_moveSpeed);
        transform.Rotate(turn * m_turnSpeed);
    }
}
/*
 * 


                                                 *************
                                              ***..... ..* +..+..
                                            $*....... .. .* +..+...
                                         $$$..........  . .* +.+.++++
                                       $$$....$$$$$$$.. .. .*.+++.***...
                                       $$$.$$$+++++++$$$... .*.+.*....+++
                                     $$$$$$.+ +++++++   *.. ..*.*..+++..++
                                    $$$$$$.+ +       ++  *.. .**..+..****..
                                    $$$$..+   .......  +  *...*.++.**..+++++
                                   $$$$..+ + +++++$$$$  + $$$$$$$$$++++     +
                                   $$$$.. + ... .....$$   $$$$$$$$$$....*****
                                  $$$$$.   ..$$.........$$$$$$$$$$$$$.......*
                           $      $++++.  .$$$$$$$$$$$$$.....$$$$$$..    ....+
                           $     $+++++.  .$$$...             ..*$$$$$     ...+
                           $$   $$+++++.  .$                  ...$$$$.    ...+
                           $*$$$$+++++*.  .$.+++/.             ...$$$$.    ...+
                           $*++++++++**.  .$.    ///    ++++/. ...$$$..    ...+
                           $++.+++++**$.  .$. $$$$$       .+/+++..$$+..    ..+
                            $*******$*$++++$   ++   .  . +++$$++.$$$+.    ...+
                            $$$$$$$$+$$$$$$         .  +   +   ..$$+..   ...+
                             $+++++++$$$$$.        .   +        .$$..   ...*
                                $****$$$$$...    ..    +/      .$$+   ...*..
                                $****$$$$$...... . ++++$$   ....$$   ...* ..
                                 $$$$**$$$....  .          ....$$  ..**++..
                                  $*****$$..   **.+**++.   ....$...$$+++..
                                   $$$$$   .     +*$$$$++   ..$$..$$$$$$.
                                    $$$    +.             ....$$$....$$.
                                           +++.          ..$$$$$$$$$$$$
                                          +.++++     ....$$$$$$ $$$$$
                                        ++....+..+.$$$$$$$$$$$$$$+++
                               +++++++++......+..+..$$$$$$$$$$$$$...++++++++++
                          ++++++++++++.........+..+....+$$$$$$...+++++++++++++++++++++
                       ++++++++.... .++++......+..+...++++ .... +++....+++++++++++++++++
                     +++++.....+....   .++++....+..+..++..++++++...........++++++++++++++
                    +... .....+++...      ..+++.+.....++++.     ..................++++++++
                   +..      ..........     ...........      ........................+++++++
                   +.       .........................................................+++++++
                   +.   ....++.....................................................++++++++++
                   +.......+++++.................................    .+++++++++++++++++++++++
                   +.......+++++..................................           .++++++++++++++++
                   *+......+++++.. ......................................        ++++++++++++++
                   *+......++++++.  .................................                /.$.+++++++
                   *+......++++++.   ........++..........................+               $.++++++
                   *+......+++*$+..    ...+++++++...................                   ...$*++++++
                    *+.....++++*$+.    ..+++++++++...  ..................+              ...$**+++++
                    *+.....++++*$...   ...+++++++++.   ...................+      ...........$***++++
                    *+.....++++*$.+.    ...+++++++++    ...............        ...........++*$**+++++
                    *+......+++$$...   ....+++++++++.   ..............................++++****$/***+++
                    *++.....+++*$..    .....+++++++++    ...............++++++++++++++++*******$$***+++
                     *+.....+++*$.     .....++++++++++.   ........... ......+******$$$$$$********$***+++
                     *++.....++*$.     .....++++++++++..    ...         .....++****$$$ $$*********$*****++
                      $+.....++$..     .....+++++++++++..                .....+++++$$$$ $$*********$$****++
                      *++....+*..      .........++++++++..            +++.....+++++$$$$ $$$***********$****+
                       *+....+*..      ...........++++**....        .+++++...++++++$$$$  $$****************+
                       *+....+*..        .........++++++*+.....   ..+++$$++.++++++$$$$$   $****************++
                        *+...+*..          ........+++++$$++.........++$+++++++++$$$$$$$   $***************++
                         *+...*...           .....++++++$$$++++........+++++++++$$$$$$$$    $****************
                         *+...*+.......++++.....++++++*$$$$$$++++++++++++++++++$$$$$$$$$$    ****************
                          $+...*+.....++$$+....+++++++$$$$$$$$$$*++++++++++*$$$$$$$$$$$$$$     **************
                           *+...$+.....++$+..+++++++*$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$++$$$$$$$     ***********
                            *+...$$$+...++++++++++*$$$$$$$$$$$$$$$$$$$$$$$$$$$$*+++.+++**$$$$$       *****
                            +......$$*+++++++*$$$$.................   ..$$$$$$*+........++$$$$$$      **
                             +......+*$$$$$$$*+..............          .......$+.....  ...+++*$$$$$
                              ++....                                  ..........$$$$$    ....+**$$$$$
                               ++++...                       ......................    .   ...++++*$$$
                                +++++...........        .............................   .    ...++++*$$
                                 ++++++..................++++++++.....................  .     ..++++++*$
                                  ++++++.....+++++++++++++$$$$$$$$$**.............$$....  .     ...++++*$
                                    +++++++++++++$$$$$$$$$$$$$$$$$$$**...........+..$$... ..     ...++++*$
                                      ++++       $$$$$$$$$$$$$$$$$$$$$**.......*$$....$$....     ...++++*$
                                                  $$$$$$................**..$$++.$$$....  ..      ...++++*$
                                                   $$$*+.....        ....***.$$....$$...  ...     ....++++$$
                                                   $$*+++.....            ***$$$$...$$$   ...     .....+++*$
                                                   $*++++++.....            *$$   ...      ..      .....+++$$
                                                   $$*+++++++..............         . ... ...      ......+++$
                                                  $$$*++...++++++..............      ........      ......+++$$
                                                  $$$$*++................     ...     .......      ......+++$$
                                                  $$$$$*++.............         ++    ........    .......+++$$
                                                  $$$$$$*++............          +     .......   . ......+++$$
                                                  $$$$$$*++..............               .....  .   ....+++**$$
                                                  $$$$$$$*+.................           .......     ....+++**$$
                                                  *$$$$$$*+++++....++++++......       ......      .....+++**$$
                                                   $$$$$$*+++............+++.....    ......       .....+++**$$
                                                   $$$$$*+++................+++.........+..       .....+++**$$
                                                    $$$$*+++.................+++++....++....      .....+++**$$
                                                    $$$$$*++......    ........++++++++......     ......+++**$$
                                                     $$$$$*++......    ........++++$$+.......    ......+++**$
                                                     $$$$$*++......      ......+++++$+.......    ......+++**$
                                                      $$$$$*++.....      .......+++*$$+.......   .....+++**$$
                                                      $$$$$**++.....      ......++++*$++......   .....+++**$
                                                       $$$$**++......      ......+++*$$++.....   .....++**$$
                                                       $$$$**+++.....       .....+++*$$$+.............++**$$
                                                        $$$$*+++......       .....+++*$$$*...........++**$$
                                                        $$$$$*+++.....       .....+++*$$$$+..........++*$$
                                                         $$$$*+++.....       .....+++*$$$$+..........++*$$
                                                          $$$$**++......      .....+++**$$$+.........+*$$
                                                           $$$$*+++.....       ....++++*$$$$+........+*$$
                                                            $$$$*+++.....      ....+++++*$$$++......+*$$
                                                             $$$$*+++....       ...+++++*$$$$++....++*$$
                                                             $$$$*+++....       ...+++++*$$$$++..++*$$
                                                              $$$$**++....       ...+++++**$$$+++++**$
                                                               $$$$**+++...       ...++++**$$$$*+++**$
                                                                $$$$**+++...      ....++++*$$$**++**$
                                                                 $$$$**++....      ....++++*$$$*+$$$
                                                                  $$$$**++...       ....+++*$$$*+**$
                                                                   $$$$**++...       ...++++*$$***$$
                                                                    $$$$**.....       ..++++*$$**$$
                                                                     $$$**+++..        ..+++*$$*$$
                                                                      $$$**++...        ..++*$$*$$
                                                                       $$$$**+...        .$$$$$$$
                                                                        $$$**+....       ...$$$$$
                                                                         $$$$+..............$$$$
                                                                          $$$.....+++........$$
                                                                          $$$... .+++........$$
                                                                          $$.....   ........*$$
                                                                         $$$...++..  ......*$$*
                                                                        $$*......++.......*+$$
                                                                       $*+...++....+......+*$$
                                                                      $*+.....+..........++$$$
                                                                     $*++...  .+.........++$$$
                                                                    $+*+++...     ......+++$$$
                                                                   $$*+++....     .....+++$$$$
                                                                  $$*+++.....     .....++$$$$$
                                                                  $*+++.....     .....+++$$$$$
                                                                 $*+++......    ...+++++$$$$$$
                                                                $**+++......   ....++++$$$$$$$
                                                               $**++.......  ....+++++$$$$$$$*
                                                               $**++.......  ....++++$$$$$$$$
                                                              $$*+++.......  ....++++$$$$$$$*
                                                              $**++.......  ...+++++$$$$$$$$
                                                              $**++......   ...+++$$$$$$$$$$
                                                              $**++.....   ...+++$$$$++*$$$$
                                                              $*++.....   ...++++$$$$*++*$$
                                                              $**+.....  ...++++$$$$++++$$$
                                                             +**.....        +$$$$++++++$$
                                                             $......        +$$$$++++ ++$$
                                                            $......        +$$$$$+++  +$$
                                                           $......        +$$$$$*++   +$$
                                                           $.....        +$$$$$$*++  ++$
                                                          $.....        + $$$$$*+++  +$$
                                                          $.....       +  $$$$$*++  ++$
                                                         $.....       +   $$$$*++  ++$$
                                                         $....      +     $$$*++   ++$
                                                        $$...      +      $$*+++  ++$$
                                                       $$...      +       $$+++   ++$

*/