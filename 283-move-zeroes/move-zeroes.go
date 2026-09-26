func moveZeroes(nums []int)  {
    s := 0
	f := 0

	for f <= len(nums) - 1 {
		if nums[f] == 0 {
			f++
		} else {
			nums[s], nums[f] = nums[f], nums[s]
			f++
			s++
		}
	}
}