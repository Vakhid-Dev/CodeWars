package main

import (
	"math"
	"sort"
)

func main() {
	println(ExpressionMatter(1, 2, 3))
}

func ExpressionMatter(a int, b int, c int) int {
	var fs = math.Max(float64(a*(b+c)), float64(a*b*c))
	var sc = math.Max(float64(a+b+c), float64((a+b)*c))
	return int(math.Max(fs, sc))
}

// Best
func ExpressionMatter_(a int, b int, c int) int {
	arr := []int{a * (b + c), a * b * c, a + b + c, (a + b) * c}
	sort.Ints(arr)
	return arr[len(arr)-1]
}
