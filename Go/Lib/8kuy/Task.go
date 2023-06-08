package _kuy

import (
	"fmt"
	"math"
	"regexp"
	"sort"
	"strconv"
	"strings"
)

func Quadratic(x1, x2 int) [3]int {
	var b = -(x1 + x2)
	var c = x1 * x2
	return [3]int{1, b, c}
}

func QuarterOf(month int) int {
	switch month {
	case 1, 2, 3:
		return 1
	case 4, 5, 6:
		return 2
	case 7, 8, 9:
		return 3
	default:
		return 4
	}
}

func Points(games []string) int {
	re := regexp.MustCompile("[0-9]+")
	counter := 0
	for _, game := range games {
		var gm = re.FindAllString(game, -1)
		var a, _ = strconv.Atoi(gm[0])
		var b, _ = strconv.Atoi(gm[1])
		if a > b {
			counter += 3
		} else if a == b {
			counter += 1
		}
	}
	return counter
}

//Best Practices

func Points_(games []string) int {
	points := 0
	for _, g := range games {
		if g[0] > g[2] {
			points += 3
		} else if g[0] == g[2] {
			points += 1
		}
	}
	return points
}

func TwiceAsOld(dadYearsOld, sonYearsOld int) int {
	var result int
	if sonYearsOld*2 <= dadYearsOld {
		result = dadYearsOld - (sonYearsOld * 2)
	} else {
		result = (sonYearsOld * 2) - dadYearsOld
	}
	return result
}

// TwiceAsOld_ Best practices
func TwiceAsOld_(dadYearsOld int, sonYearsOld int) int {
	return int(math.Abs(float64(dadYearsOld - (sonYearsOld * 2))))
}

func countSheep(num int) string {

	var res string
	for i := 1; i <= 3; i++ {
		res += fmt.Sprintf("%v sheep...", i)
	}
	return res
}

// Best practices
func countSheep_(num int) string {
	var sb strings.Builder
	for count := 1; count <= num; count++ {
		fmt.Fprintf(&sb, "%d sheep...", count)
	}

	return sb.String()
}

func ExpressionMatter(a int, b int, c int) int {
	var fs = math.Max(float64(a*(b+c)), float64(a*b*c))
	var sc = math.Max(float64(a+b+c), float64((a+b)*c))
	return int(math.Max(fs, sc))
}

// ExpressionMatter_ Best  practices
func ExpressionMatter_(a int, b int, c int) int {
	arr := []int{a * (b + c), a * b * c, a + b + c, (a + b) * c}
	sort.Ints(arr)
	return arr[len(arr)-1]
}

func multipleOfIndex(ints []int) []int {
	var arr []int
	for i := 1; i < len(ints); i++ {
		if ints[i]%i == 0 {
			arr = append(arr, ints[i])
		}
	}
	return arr
}

func ToCsvText(array [][]int) string {
	var str string
	var mas []string
	for i := 0; i < len(array); i++ {

		for _, el := range array[i] {
			str += fmt.Sprintf("%v,", el)
		}
		mas = append(mas, strings.TrimRight(str, ","))
		str = ""
	}
	return strings.Join(mas, "\n")
}
