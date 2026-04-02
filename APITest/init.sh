#!/bin/bash 
export CYAN_COLOR="\033[36;1m"
export RED_COLOR="\033[32;1m"
export NO_COLOR="\033[0m"
# shellcheck disable=SC1091
source ./bash_scripts/tests/test.sh
# shellcheck disable=SC1091
source ./bash_scripts/base/boilerplate.sh
# shellcheck disable=SC1091
source ./bash_scripts/tests/e2e/edata.sh

ui() {
    echo -e "${CYAN_COLOR} 1)[tests][api][get_all]${NO_COLOR}"
    echo -e "${CYAN_COLOR} 2)[base][boilerplate]${NO_COLOR}"
    echo -e "${CYAN_COLOR} 3)[tests][api][create_edata]${NO_COLOR}"
    echo -e "${CYAN_COLOR} 4)[tests][api][e2e][create_get_edata]${NO_COLOR}"
    read -r -p "Make your choice: " choice
    case $choice in
        1) test_get_all_edatas ;;
        2) create_boilerplate ;;
        3) test_create_edata ;;
        4) create_edata_get_all_datas ;;
        *) echo "Unknown choice"
    esac
}
ui