package main

import (
	"fmt"
	"sort"
)

func main() {
	fmt.Println(MergeArrays([]int{1, 2, -9, 3, 4}, []int{5, 6, 7, 8, -9}))
}

func MergeArrays(arr1, arr2 []int) []int {
	var res []int
	for i := 0; i < len(arr1); i++ {
		if !contains(res, arr1[i]) {
			res = append(res, arr1[i])
		}
	}
	//for arr2
	for i := 0; i < len(arr2); i++ {
		if !contains(res, arr2[i]) {
			res = append(res, arr2[i])
		}
	}
	sort.Ints(res)
	return res
}

func contains(s []int, e int) bool {
	for _, a := range s {
		if a == e {
			return true
		}
	}
	return false
}
