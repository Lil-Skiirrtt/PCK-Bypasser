# PCK-Bypasser
![Capture d’écran 2023-01-27 221307](https://user-images.githubusercontent.com/63059967/215201752-a576eaa0-a8ae-4f96-a651-c7676a011fdc.png)
![Capture d’écran 2023-01-27 221321](https://user-images.githubusercontent.com/63059967/215201787-03752436-7a54-4bcd-a4a6-586c1d44721e.png)

Here is the breach

```
//I have replaced this

				if (mineFile.name == "0")
				{
					foreach (object[] array in mineFile.entries)
					{
						if (array[0].ToString() == "LOCK" && (new pckLocked(array[1].ToString(), FormMain.correct).ShowDialog() == DialogResult.OK || FormMain.correct))
						{
							return;
						}
					}
				}
			}

//By this

				if (mineFile.name == "0")
				{
					foreach (object[] array in mineFile.entries)
					{
						if (array[0].ToString() == "LOCK" && (new pckLocked(array[1].ToString(), FormMain.correct).ShowDialog() != DialogResult.OK || FormMain.correct))
						{
							return;
						}
					}
				}
			}
```
