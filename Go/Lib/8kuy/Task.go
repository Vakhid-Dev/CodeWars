package _kuy

import (
	"regexp"
	"strconv"
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
