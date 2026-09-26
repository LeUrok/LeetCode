func twoSum(numbers []int, target int) []int {
    b := 0
	e := len(numbers) - 1

	for b < e {
		if numbers[b] + numbers[e] == target {
			return []int{b + 1,e + 1}
		}
		if numbers[b] + numbers[e] > target {
			e--
		}
		if numbers[b] + numbers[e] < target {
			b++
		}
	}
	return []int{}
}