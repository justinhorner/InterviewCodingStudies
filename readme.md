# Interview Coding Studies

This is a solution that holds classes (and related unit test classes) for coding puzzles / questions from LeetCode.

## Median of Two Sorted Arrays

- #4. Median of Two Sorted Arrays
- https://leetcode.com/problems/median-of-two-sorted-arrays/


Given two sorted arrays `nums1` and `nums2` of size `m` and `n` respectively, return the median of the two sorted arrays.

The overall run time complexity should be `O(log (m+n))`.

### Example 1:

```
Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
```

### Example 2:

```
Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
```

### Constraints:

- `nums1.length == m`
- `nums2.length == n`
- `0 <= m <= 1000`
- `0 <= n <= 1000`
- `1 <= m + n <= 2000`
- `10<sup>6</sup> <= nums1[i], nums2[i] <= 10<sup>6</sup>`

----

## Number of Islands

- 200. Number of Islands
- https://leetcode.com/problems/number-of-islands/

Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 

You may assume all four edges of the grid are
all surrounded by water.


### Example 1:
 ```
	grid = [
	["1","1","1","1","0"],
	["1","1","0","1","0"],
	["1","1","0","0","0"],
	["0","0","0","0","0"] ]
	Output: 1
```

### Example 2:
```
	grid = [
	["1","1","0","0","0"],
	["1","1","0","0","0"],
	["0","0","1","0","0"],
	["0","0","0","1","1"] ]
	Output: 3
```

----

## Rectangle Area

- #223. Rectangle Area
- https://leetcode.com/problems/rectangle-area/

Given the coordinates of two rectilinear rectangles in a 2D plane, return *the total area covered by the two rectangles*.

The first rectangle is defined by its bottom-left corner `(ax1, ay1)` and its top-right corner `(ax2, ay2)`.

The second rectangle is defined by its bottom-left corner `(bx1, by1)` and its top-right corner `(bx2, by2)`.


### Example 1:

![Example image](https://assets.leetcode.com/uploads/2021/05/08/rectangle-plane.png)

```
Input: ax1 = -3, ay1 = 0, ax2 = 3, ay2 = 4, bx1 = 0, by1 = -1, bx2 = 9, by2 = 2
Output: 45
```

### Example 2:

```
Input: ax1 = -2, ay1 = -2, ax2 = 2, ay2 = 2, bx1 = -2, by1 = -2, bx2 = 2, by2 = 2
Output: 16
```

### Constraints:

- -10<sup>4</sup> <= ax1 <= ax2 <= 10<sup>4</sup>
- -10<sup>4</sup> <= ay1 <= ay2 <= 10<sup>4</sup>
- -10<sup>4</sup> <= bx1 <= bx2 <= 10<sup>4</sup>
- -10<sup>4</sup> <= by1 <= by2 <= 10<sup>4</sup>

----

## Regular Expression Matching

- #10. Regular Expression Matching
- https://leetcode.com/problems/regular-expression-matching/

Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
- `.` Matches any single character.
- `*` Matches zero or more of the preceding element.

The matching should cover the entire input string (not partial).

### Example 1:

```
Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
```

### Example 2:

```
Input: s = "aa", p = "a*"
Output: true
Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
```

### Example 3:

```
Input: s = "ab", p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
```

### Constraints:

- `1 <= s.length <= 20`
- `1 <= p.length <= 20`
- `s` contains only lowercase English letters.
- `p` contains only lowercase English letters, `.`, and `*`.
- It is guaranteed for each appearance of the character `*`, there will be a previous valid character to match.

----