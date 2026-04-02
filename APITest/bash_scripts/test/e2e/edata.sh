#!/bin/bash 
# shellcheck disable=SC1091
source "$(dirname "${BASH_SOURCE[0]}")/../test.sh"

create_edata_get_all_datas() {
    test_create_edata
    sleep 5
    test_get_all_edatas

}