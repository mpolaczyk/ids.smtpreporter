ids.smtpreporter 1.1 (Powiadamiacz/Notifier)
========================================

This tool is created to send notifications via smtp.

**Features:**
 - Resides in Windows taskbar
 - Can send email notifications
 - Checks public ip
 - Other types of checks can be implemented
 
**To do:**
 - English localization
 - Background workers

**Installation:**
 - Download source code
 - Compile sources
 - Run
 - Look for eyes in taskbar

**Initial configuration:**
 - In settings tab, enter instance name - will be appended to subject of a notification email (designed to recognize mails from various hosts)
 - In settings tab, enter smtp settings (this tool uses smtp with ssl authentication)
 - In public ip check tab, hit test to initialize cycle.

**Sample SMTP configuration:**
Server: smtp.googlemail.com
Port: 587
User: <login to your google account, this account will be used as sender>
Pass: <pass to your google account>
Receiver: <this is a destination address, he will receive reports>
