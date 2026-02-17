import random

def snowflake(seed: str, radius: int | None = None) -> str:
    random.seed(seed)

    # choose drawing characters based on seed
    arms = random.choice(["*", "+", "x", "o", "#", "@"])
    fill = random.choice([".", " ", ".", " "])  # bias toward airy look
    center = random.choice(["*", "+", "O", "@", "X"])

    # pick radius from seed if not provided
    if radius is None:
        radius = random.randint(3, 8)

    n = radius * 2 + 1
    cx = cy = radius

    # helper to set symmetric points
    def put(grid, x, y, ch):
        pts = [
            ( x,  y),
            (-x,  y),
            ( x, -y),
            (-x, -y),
            ( y,  x),
            (-y,  x),
            ( y, -x),
            (-y, -x),
        ]
        for px, py in pts:
            gx, gy = cx + px, cy + py
            if 0 <= gy < n and 0 <= gx < n:
                grid[gy][gx] = ch

    # start with filled background
    grid = [[fill for _ in range(n)] for _ in range(n)]

    # draw 6/8 arms using Bresenham-like steps on diagonals and cardinals
    for r in range(radius + 1):
        put(grid, r, 0, arms)      # horizontal
        put(grid, 0, r, arms)      # vertical
        put(grid, r, r, arms)      # main diagonal

    # add some flakes/branches along the arms for variety
    for k in range(1, radius):
        if random.random() < 0.7:
            put(grid, k, 0, arms)
            put(grid, k, 1, arms)
        if random.random() < 0.7:
            put(grid, 0, k, arms)
            put(grid, 1, k, arms)
        if random.random() < 0.7:
            put(grid, k, k, arms)
            if k+1 <= radius:
                put(grid, k, k+1, arms)

    # center
    grid[cy][cx] = center

    return "\n".join("".join(row) for row in grid)

if __name__ == "_main_":
    s = input("Seed: ").strip() or "demo"
    print(snowflake(s))