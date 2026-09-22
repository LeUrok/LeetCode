func merge(nums1 []int, m int, nums2 []int, n int)  {
    p1 := m - 1
    p2 := n - 1 
    q := n + m - 1 

    for p1 >= 0 && p2 >= 0 {
        if nums2[p2] >= nums1[p1] {
            nums1[q] = nums2[p2]
            p2--
        } else {
            nums1[q] = nums1[p1]
            p1--
        }
        q--
    }
    for p2 >= 0 {
        nums1[q] = nums2[p2]
        p2 --
        q--
    }
}