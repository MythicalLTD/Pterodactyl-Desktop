
![Logo](https://i.imgur.com/xI3GLFc.jpeg)

# PteroControler

A Pterodactyl Panel desktop app that uses the Client API!


<p><img src="https://discord.com/api/guilds/1080933452091752448/widget.png?style=shield" />

## Download

Here are some download links:

SOON


## Support

For support join our Discord server.

Discord: [discord.gg/mythicalsystems](https://discord.gg/7BZTmSK2D8)


## Features

- Server List
- Live Console
- No delay
- Free <3


## For Hosting Services!

To allow the usage of this app, you will have to edit your wings configuration

!!WARNING BY ENABLING THIS YOU ARE NOT PUTTING YOUR HOST AT RISK ITS SAFE JUST THAT IT'S NOT ENABLED BY DEFAULT SINCE THE PANEL DOES NOT REQUIRE EXTERNAL ACCESS!!

First go to all your nodes wings configuration directory

```bash
  cd /etc/pterodactyl
```
 Then edit the configuration file using:

```bash
  nano config.yml
```
Now go to the bottom of the file where allowed_origins is and remove it with `CTRL K` and add this instead
```bash
allowed_origins:
- '*'
```
This will allow the app to connect to the server console!

Remember this needs to be done for every node on your panel!

If this is not enabled, the app will work fine except for the console
## FAQ

#### Is this a virus?

No our app is 100% safe and has no virus inside it or any kind keyloger etc

#### Why dose windows show a warning when i open the app?
Because the app is not signed by Microsoft yet

#### If my host does not setup the console access, can I still see my console?
No sadly no because we use a method called WebSockets to get the live console info

#### Is this really free?
Yes it's totally free forever

#### Is there another theme?
No currently the app is still in development, and we don't provide themes yet but if you are excellent as a designer in winforms you can make your own theme 
## Authors

- [@NaysKutzu](https://github.com/NaysKutzu)


## License

[MIT](https://choosealicense.com/licenses/mit/)


## Used By

This project is used by the following companies:

- [MythicalSystems](https://mythicalsystems.tech)
- [NoxlCraft](https://noxlcraft.me)

[IF YOU WANT YOUR NAME HERE DM ME ON DISCORD: `NaysKutzu#5375`]


## Tech Stack

**Client:** C#, WinForms, .NET

**Server:** Pterodactyl

