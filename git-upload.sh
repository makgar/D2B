#!/bin/bash

git add .
git commit -m "$(date '+%Y%m%d_%H_%M')_upload_from_cli"
git push origin master
