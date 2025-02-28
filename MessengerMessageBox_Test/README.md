This Project is using code from Dark-Mode-Forms by BlueMystical(https://github.com/BlueMystical/Dark-Mode-Forms)

It is intended to showcase the differences between the standard WinForms MessageBox and the new Messenger.MessageBox provided as part of the Dark-Mode-Forms project.

There are a number of changes to the original code to bring Messenger.MessageBox more in line with the behavior of the standard MessageBox. The buttons are in the correct order, the text alignment is set to left-aligned and the behavior of the control is modified such as to prevent closing via the Escape key or the ControlBox (X in upper-right corner) whenever the dialog does not contain a Cancel button. Also the MessageBox.OK dialog returns DialogResult.OK always, as per the standard dialog.

One other addition is a language translation for Portuguese (pt) for the MessageBox (untested since I don't have any language packs installed).

This is not a fork of BlueMystical's project, but rather a demo of how the code can work and hopefully be improved.