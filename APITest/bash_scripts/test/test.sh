#!/bin/bash
set -euo pipefail

test_get_all_edatas() {
    curl -Ss -X GET http://localhost:5078/edatas
}


test_create_edata() {
    curl -H 'Content-Type:application/json' \
    -d '{"id": 10, "name": "current_process", "content": "./init.sh"}' \
    -X POST http://localhost:5078/edatas

}
