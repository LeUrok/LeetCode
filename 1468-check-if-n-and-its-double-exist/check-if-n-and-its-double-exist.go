func checkIfExist(arr []int) bool {
    i := 0
	for i < len(arr) {
		if arr[i] % 2 == 0 {
			for j := range arr {
				if arr[j]*2 == arr[i] && i != j {
					return true
				}
			}
		}
		i++
	}
	return false
}