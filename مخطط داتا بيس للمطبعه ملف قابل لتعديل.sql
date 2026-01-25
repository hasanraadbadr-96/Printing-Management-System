CREATE TABLE `الشخص`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `الاسم الثلاثي` VARCHAR(255) NOT NULL,
    `رقم الهاتف` VARCHAR(255) NOT NULL,
    `العنوان` VARCHAR(255) NOT NULL,
    `ملاحظات` VARCHAR(255) NOT NULL,
    `عدد الطلبيات` INT NOT NULL,
    `تاريخ أول تعامل` DATETIME NOT NULL,
    `تاريخ اخر تعامل` DATETIME NOT NULL,
    `id حاله الشخص` INT NOT NULL
);
CREATE TABLE `حاله الشخص`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `زبون اذا عدد طلبياته  3 او اكثر` INT NOT NULL,
    `عميل اذا عدد طلبياته اقل من 3` INT NOT NULL,
    `إدارة الطلب` INT NOT NULL
);
CREATE TABLE `إدارة المنتج`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `اسم المنتج` VARCHAR(255) NOT NULL,
    `السعر` DOUBLE NOT NULL,
    `هل المنتج متوفر؟` BOOLEAN NOT NULL,
    `هل عليه طلبات كثيرة؟` BOOLEAN NOT NULL,
    `عدد مرات طلب الشخص على المنتج` INT NOT NULL
);
CREATE TABLE `إدارة المخزن`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `كمية المنتج المتوفرة` INT NOT NULL,
    `كميةالمنتج  النافذة (المستخدمة)` INT NOT NULL,
    `حالة توفر المنتج  (متوفر/غير متوفر)` BOOLEAN NOT NULL,
    `id ادارة المنتج` INT NOT NULL
);
CREATE TABLE `إدارة الطلب`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `اسم المنتج المطلوب` VARCHAR(255) NOT NULL,
    `سعر الطلبية` DOUBLE NOT NULL,
    `حالة التوصيل (مع توصيل أو بدون)` VARCHAR(255) NOT NULL,
    `تاريخ الطلب` DATETIME NOT NULL,
    `الوقت المتوقع لإنجاز الطلب` DATETIME NOT NULL,
    `هل تم دفع العربون؟` BOOLEAN NOT NULL,
    `مبلغ العربون المدفوع` DOUBLE NOT NULL,
    `هل المنتج متوفر وقت الطلب؟` VARCHAR(255) NOT NULL,
    `id ادرة المنتج` INT NOT NULL,
    `id الشخص` INT NOT NULL
);
CREATE TABLE `إدارة صندوق الأموال`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `اسم الصندوق` VARCHAR(255) NOT NULL,
    `الرصيد المالي داخل الصندوق` DOUBLE NOT NULL,
    `نسبة الشراكة أو حصة الصندوق` DOUBLE NOT NULL,
    `الأموال المودعة من الطلبيات` DOUBLE NOT NULL,
    `الأموال المسحوبة` DOUBLE NOT NULL,
    `تاريخ الإيداع` DATETIME NOT NULL,
    `تاريخ السحب` DATETIME NOT NULL,
    `id ادارة الطلب` INT NOT NULL
);
CREATE TABLE `تحويل المال بين الصناديق`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `من أي صندوق تم التحويل` VARCHAR(255) NOT NULL,
    `لى أي صندوق تم التحويل` VARCHAR(255) NOT NULL,
    `المبلغ المحوّل` DOUBLE NOT NULL,
    `اسم الشخص الذي حول المبلغ` VARCHAR(255) NOT NULL,
    `اسم المستلم` VARCHAR(255) NOT NULL,
    `التاريخ والوقت` DATETIME NOT NULL,
    `المستخدم الذي نفّذ العملية` VARCHAR(255) NOT NULL,
    `id ادارة صندوق المال` INT NOT NULL,
    `ادارة المستخدم (الموضف)  id` INT NOT NULL,
    `id ادارة العملة` INT NOT NULL
);
CREATE TABLE `إدارة الدين`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `اسم المديون` VARCHAR(255) NOT NULL,
    `رقم هاتفه` VARCHAR(255) NOT NULL,
    `عنوانه` VARCHAR(255) NOT NULL,
    `تاريخ الدين` DATETIME NOT NULL,
    `المبلغ المطلوب` DOUBLE NOT NULL,
    `الطلبية المرتبطة  بالشخص` VARCHAR(255) NOT NULL,
    `id الشخص` INT NOT NULL,
    `id ادارة الطلب` INT NOT NULL,
    `id مستخدم` INT NOT NULL
);
CREATE TABLE `إدارة المستخدم (الموظف)`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `الاسم الكامل` VARCHAR(255) NOT NULL,
    `رقم الهاتف` VARCHAR(255) NOT NULL,
    `كلمة السر` VARCHAR(255) NOT NULL,
    `نوع الصلاحيات (ممثلة برقم ثنائي)` INT NOT NULL,
    `صلاحية المستخدم(الموضف) id` BIGINT NOT NULL
);
CREATE TABLE `سجل الدخول للمستخدم`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `معرف الدخول` INT NOT NULL,
    `اسم المستخدم` VARCHAR(255) NOT NULL,
    `رقم هاتفه` VARCHAR(255) NOT NULL,
    `تاريخ الدخول` DATETIME NOT NULL,
    `صلاحيات المستخدم وقت الدخول` INT NOT NULL,
    `رمز المستخدم` VARCHAR(255) NOT NULL,
    `id صلاحية المستخدم` INT NOT NULL,
    `id ادارة المستخدم` INT NOT NULL
);
CREATE TABLE `إدارة العمله`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `اسم الدولة` VARCHAR(255) NOT NULL,
    `رمز الدولة` VARCHAR(255) NOT NULL,
    `اسم العملة` VARCHAR(255) NOT NULL,
    `قيمة التحويل مقابل الدولار` DOUBLE NOT NULL
);
CREATE TABLE `صلاحية المستخدم (الموضف)`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `الصلاحيه علئ النضام كامل ممثل برقم  -1` INT NOT NULL,
    `توجد صلاحية علئ بعض النضام او لا توجد مطلقا` INT NOT NULL
);
ALTER TABLE
    `إدارة الدين` ADD CONSTRAINT `إدارة الدين_id ادارة الطلب_foreign` FOREIGN KEY(`id ادارة الطلب`) REFERENCES `إدارة الطلب`(`id`);
ALTER TABLE
    `إدارة الدين` ADD CONSTRAINT `إدارة الدين_id الشخص_foreign` FOREIGN KEY(`id الشخص`) REFERENCES `الشخص`(`id`);
ALTER TABLE
    `تحويل المال بين الصناديق` ADD CONSTRAINT `تحويل المال بين الصناديق_id ادارة العملة_foreign` FOREIGN KEY(`id ادارة العملة`) REFERENCES `إدارة العمله`(`id`);
ALTER TABLE
    `إدارة الدين` ADD CONSTRAINT `إدارة الدين_id مستخدم_foreign` FOREIGN KEY(`id مستخدم`) REFERENCES `إدارة المستخدم (الموظف)`(`id`);
ALTER TABLE
    `سجل الدخول للمستخدم` ADD CONSTRAINT `سجل الدخول للمستخدم_id صلاحية المستخدم_foreign` FOREIGN KEY(`id صلاحية المستخدم`) REFERENCES `صلاحية المستخدم (الموضف)`(`id`);
ALTER TABLE
    `إدارة المستخدم (الموظف)` ADD CONSTRAINT `إدارة المستخدم (الموظف)_صلاحية المستخدم(الموضف) id_foreign` FOREIGN KEY(`صلاحية المستخدم(الموضف) id`) REFERENCES `صلاحية المستخدم (الموضف)`(`id`);
ALTER TABLE
    `إدارة الطلب` ADD CONSTRAINT `إدارة الطلب_id ادرة المنتج_foreign` FOREIGN KEY(`id ادرة المنتج`) REFERENCES `إدارة المنتج`(`id`);
ALTER TABLE
    `إدارة الطلب` ADD CONSTRAINT `إدارة الطلب_id الشخص_foreign` FOREIGN KEY(`id الشخص`) REFERENCES `الشخص`(`id`);
ALTER TABLE
    `إدارة المخزن` ADD CONSTRAINT `إدارة المخزن_id ادارة المنتج_foreign` FOREIGN KEY(`id ادارة المنتج`) REFERENCES `إدارة المنتج`(`id`);
ALTER TABLE
    `سجل الدخول للمستخدم` ADD CONSTRAINT `سجل الدخول للمستخدم_id ادارة المستخدم_foreign` FOREIGN KEY(`id ادارة المستخدم`) REFERENCES `إدارة المستخدم (الموظف)`(`id`);
ALTER TABLE
    `تحويل المال بين الصناديق` ADD CONSTRAINT `تحويل المال بين الصناديق_ادارة المستخدم (الموضف)  id_foreign` FOREIGN KEY(`ادارة المستخدم (الموضف)  id`) REFERENCES `إدارة المستخدم (الموظف)`(`id`);
ALTER TABLE
    `إدارة صندوق الأموال` ADD CONSTRAINT `إدارة صندوق الأموال_id ادارة الطلب_foreign` FOREIGN KEY(`id ادارة الطلب`) REFERENCES `إدارة الطلب`(`id`);
ALTER TABLE
    `الشخص` ADD CONSTRAINT `الشخص_id حاله الشخص_foreign` FOREIGN KEY(`id حاله الشخص`) REFERENCES `حاله الشخص`(`id`);