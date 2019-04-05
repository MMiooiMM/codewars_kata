# https://www.codewars.com/kata/getting-along-with-integer-partitions/

def prod(n):
    ret = [{1.}]
    for i in range(1, n+1):
        print(ret)
        ret.append({(i - x) * j for x, s in enumerate(ret) for j in s})
    print(ret)
    print(ret[-1])
    return ret[-1]


def part(n):
    p = sorted(prod(n))
    return "Range: %d Average: %.2f Median: %.2f" % \
        (p[-1] - p[0], sum(p) / len(p), (p[len(p)//2] + p[~len(p)//2]) / 2)


print(part(8))
