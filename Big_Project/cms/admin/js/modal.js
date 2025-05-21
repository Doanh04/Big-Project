function showWelcomeMessage(email) {
    const modalBody = document.querySelector('.modal-body');
    const modalFooter = document.querySelector('.modal-footer');

    modalBody.innerHTML = `
            <h5>Xin chào: ${email}</h5>
            <p>Chào mừng bạn đến với Cake & Candy - nơi sẽ bán cho bạn tất cả những gì ngọt ngào nhất!</p>
        `;

    modalFooter.innerHTML = `
            <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
            <a href="Logout.aspx" class="btn btn-danger">Đăng xuất</a>
        `;
}