-- ==========================================
-- SHAFAYE SALON DATABASE USER ADMINISTRATION (SAFE IMPORT VERSION)
-- ==========================================

-- Ensure database exists first
CREATE DATABASE IF NOT EXISTS final_shafaye_salon;

-- 1. CREATE ADMIN USER
CREATE USER IF NOT EXISTS 'salon_admin'@'localhost' 
IDENTIFIED BY 'AdminSalon2025!';

GRANT ALL PRIVILEGES ON final_shafaye_salon.* 
TO 'salon_admin'@'localhost';

-- 2. CREATE STAFF USER
CREATE USER IF NOT EXISTS 'salon_staff'@'localhost' 
IDENTIFIED BY 'StaffSalon2025!';

GRANT SELECT ON final_shafaye_salon.appointments TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.appointment_services TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.services TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_categories TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.payments TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.user_register TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.user_profiles TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.staff TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.reviews TO 'salon_staff'@'localhost';

-- 3. CREATE CUSTOMER/USER
CREATE USER IF NOT EXISTS 'salon_customer'@'localhost' 
IDENTIFIED BY 'CustomerSalon2025!';

GRANT SELECT ON final_shafaye_salon.services TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_categories TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.faq TO 'salon_customer'@'localhost';

GRANT SELECT, INSERT ON final_shafaye_salon.appointments TO 'salon_customer'@'localhost';
GRANT SELECT, INSERT ON final_shafaye_salon.appointment_services TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.staff TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_staff_roles TO 'salon_customer'@'localhost';

GRANT UPDATE (status) ON final_shafaye_salon.appointments TO 'salon_customer'@'localhost';

GRANT SELECT, INSERT ON final_shafaye_salon.reviews TO 'salon_customer'@'localhost';

GRANT SELECT, UPDATE ON final_shafaye_salon.user_profiles TO 'salon_customer'@'localhost';
GRANT SELECT, UPDATE ON final_shafaye_salon.user_register TO 'salon_customer'@'localhost';

GRANT SELECT, INSERT ON final_shafaye_salon.contact_messages TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.payments TO 'salon_customer'@'localhost';

-- 4. CREATE WEB APPLICATION USER
CREATE USER IF NOT EXISTS 'salon_webapp'@'localhost' 
IDENTIFIED BY 'WebApp2025!';

GRANT SELECT, INSERT, UPDATE, DELETE ON final_shafaye_salon.* 
TO 'salon_webapp'@'localhost';

-- 5. SECURITY ENHANCEMENTS

-- Limit customer's view of staff
REVOKE SELECT ON final_shafaye_salon.staff FROM 'salon_customer'@'localhost';
GRANT SELECT (staff_id, user_id, position, status) ON final_shafaye_salon.staff 
TO 'salon_customer'@'localhost';

-- 6. SAFETY GRANTS
GRANT USAGE ON final_shafaye_salon.* TO 'salon_staff'@'localhost';
GRANT USAGE ON final_shafaye_salon.* TO 'salon_customer'@'localhost';

-- 7. FINALIZE
FLUSH PRIVILEGES;

-- ==========================================
-- OPTIONAL: VERIFICATION QUERIES (comment out if not needed)
-- ==========================================
-- SHOW GRANTS FOR 'salon_admin'@'localhost';
-- SHOW GRANTS FOR 'salon_staff'@'localhost';
-- SHOW GRANTS FOR 'salon_customer'@'localhost';
-- SHOW GRANTS FOR 'salon_webapp'@'localhost';
