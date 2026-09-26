func judgeSquareSum(c int) bool {
    p1 := 0
	p2 := int(math.Sqrt(float64(c)))

	for p1 <= p2 {
		if p1 * p1 + p2 * p2 == c {
			return true
		}
		if p1 * p1 + p2 * p2 > c {
			p2--
		} else {
			p1++
		}
	}
	return false
}