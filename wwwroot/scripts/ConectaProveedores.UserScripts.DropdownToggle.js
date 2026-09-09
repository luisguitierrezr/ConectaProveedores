(function () {
  const CONTAINER_SEL = ".dropdown-container";
  const SELECT_SEL = ".dropdown-container > select.dropdown-display";
  const ACTIVE_CLASS = "os-dd-active";

  const OPEN_LOCK_MS = 550;

  // Per-dropdown open lock
  const lockUntilByContainer = new WeakMap();

  document.addEventListener("click", (e) => {
    const sel = e.target.closest && e.target.closest(SELECT_SEL);
    if (!sel) return;

    const container = sel.closest(CONTAINER_SEL);
    if (!container) return;

    const now = Date.now();
    const lockUntil = lockUntilByContainer.get(container) || 0;

    // Ignore clicks during post-open lock for THIS dropdown only
    if (now < lockUntil) return;

    const isOpen = container.classList.contains(ACTIVE_CLASS);

    if (!isOpen) {
      // 🔹 CLOSE ALL OTHER DROPDOWNS IMMEDIATELY
      document
        .querySelectorAll(CONTAINER_SEL + "." + ACTIVE_CLASS)
        .forEach(el => {
          if (el !== container) el.classList.remove(ACTIVE_CLASS);
        });

      // OPEN this dropdown and start its lock
      container.classList.add(ACTIVE_CLASS);
      lockUntilByContainer.set(container, now + OPEN_LOCK_MS);
    } else {
      // CLOSE immediately (no lock)
      container.classList.remove(ACTIVE_CLASS);
    }
  });

  document.addEventListener("change", (e) => {
    const sel = e.target.closest && e.target.closest(SELECT_SEL);
    if (!sel) return;

    const container = sel.closest(CONTAINER_SEL);
    if (!container) return;

    container.classList.remove(ACTIVE_CLASS);
  });

  document.addEventListener("mousedown", (e) => {
    if (e.target.closest && e.target.closest(CONTAINER_SEL)) return;

    document
      .querySelectorAll(CONTAINER_SEL + "." + ACTIVE_CLASS)
      .forEach(el => el.classList.remove(ACTIVE_CLASS));
  });
})();