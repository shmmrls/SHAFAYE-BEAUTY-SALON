-- ==========================================
-- SHAFAYE SALON DATABASE USER ADMINISTRATION
-- Based on Actual VB.NET System Implementation
-- ==========================================

-- 1. CREATE ADMIN USER
-- Full system access for administrators
CREATE USER 'salon_admin'@'localhost' 
IDENTIFIED BY 'AdminSalon2025!';

-- ADMIN gets complete access to everything
GRANT ALL PRIVILEGES ON final_shafaye_salon.* 
TO 'salon_admin'@'localhost';

-- 2. CREATE STAFF USER
-- Limited read-only access based on staff menu
CREATE USER 'salon_staff'@'localhost' 
IDENTIFIED BY 'StaffSalon2025!';

-- STAFF PERMISSIONS (Read-only access):
-- Can only view: Daily Overview, View Appointments, Service List

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
-- Based on userMenu.vb - exact customer functionality
CREATE USER 'salon_customer'@'localhost' 
IDENTIFIED BY 'CustomerSalon2025!';

-- CUSTOMER PERMISSIONS based on VB.NET userMenu code:

-- FOR HOME FUNCTIONALITY (home form):
-- View general salon information, announcements, etc.
GRANT SELECT ON final_shafaye_salon.services TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_categories TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.faq TO 'salon_customer'@'localhost';

-- FOR SERVICES FUNCTIONALITY (services form):
-- Browse available services and categories
-- (Already granted above)

-- FOR BOOK APPOINTMENT FUNCTIONALITY (bookappointment form):
-- Create new appointments and select services
GRANT SELECT, INSERT ON final_shafaye_salon.appointments TO 'salon_customer'@'localhost';
GRANT SELECT, INSERT ON final_shafaye_salon.appointment_services TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.staff TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_staff_roles TO 'salon_customer'@'localhost';

-- Allow customers to cancel their own appointments
GRANT UPDATE (status) ON final_shafaye_salon.appointments TO 'salon_customer'@'localhost';

-- FOR REVIEWS FUNCTIONALITY (reviews form):
-- Leave reviews and ratings for completed services
GRANT SELECT, INSERT ON final_shafaye_salon.reviews TO 'salon_customer'@'localhost';

-- View their own appointments to review
-- (Already granted above for appointments table)

-- FOR PROFILE FUNCTIONALITY (profile form):
-- Manage their personal information
GRANT SELECT, UPDATE ON final_shafaye_salon.user_profiles TO 'salon_customer'@'localhost';

-- FOR USER REGISTRATION FUNCTIONALITY:
-- Allow customers to view and update their registration info (password changes, account updates, etc.)
GRANT SELECT, UPDATE ON final_shafaye_salon.user_register TO 'salon_customer'@'localhost';

-- FOR CUSTOMER SUPPORT FUNCTIONALITY (CustomerSupport form):
-- Send messages/inquiries to salon management
GRANT SELECT, INSERT ON final_shafaye_salon.contact_messages TO 'salon_customer'@'localhost';

-- FOR TRANSACTION HISTORY FUNCTIONALITY (transactionhistory form):
-- View their payment history and completed appointments
GRANT SELECT ON final_shafaye_salon.payments TO 'salon_customer'@'localhost';

-- 4. CREATE WEB APPLICATION USER
-- For backend system connectivity
CREATE USER 'salon_webapp'@'localhost' 
IDENTIFIED BY 'WebApp2025!';

-- Full database access for web application operations
GRANT SELECT, INSERT, UPDATE, DELETE ON final_shafaye_salon.* 
TO 'salon_webapp'@'localhost';

-- 5. REFRESH PRIVILEGES
FLUSH PRIVILEGES;

-- ==========================================
-- CUSTOMER ACCESS SUMMARY (Based on userMenu.vb)
-- ==========================================

-- CUSTOMER CAN ACCESS:
-- ✓ Home (salon info, announcements)
-- ✓ Services (browse available services)
-- ✓ Book Appointment (create appointments, select services)
-- ✓ Reviews (leave ratings for completed services)
-- ✓ Profile (manage personal information)
-- ✓ User Registration Updates (password changes, account info)
-- ✓ Customer Support (send inquiries)
-- ✓ Transaction History (view payment records)
-- ✓ Logout (session management)

-- CUSTOMER CANNOT ACCESS:
-- ✗ Admin functions
-- ✗ Staff management
-- ✗ Service creation/editing
-- ✗ Expense management
-- ✗ Inventory management
-- ✗ Other customers' data
-- ✗ Staff salary information
-- ✗ System configuration

-- ==========================================
-- STAFF ACCESS SUMMARY (Based on staffMenu.vb)
-- ==========================================

-- STAFF CAN ACCESS:
-- ✓ Daily Overview (appointment statistics)
-- ✓ View Appointments (all bookings)
-- ✓ Service List (available services)
-- ✓ Logout

-- STAFF CANNOT ACCESS:
-- ✗ Admin Dashboard
-- ✗ Admin Profile  
-- ✗ Appointment Management (modify)
-- ✗ Any INSERT/UPDATE/DELETE operations
-- ✗ Expense/Inventory/User management

-- ==========================================
-- VERIFICATION QUERIES
-- ==========================================

-- Check all user privileges
SHOW GRANTS FOR 'salon_admin'@'localhost';
SHOW GRANTS FOR 'salon_staff'@'localhost';
SHOW GRANTS FOR 'salon_customer'@'localhost';
SHOW GRANTS FOR 'salon_webapp'@'localhost';

-- ==========================================
-- SECURITY ENHANCEMENTS
-- ==========================================

-- Prevent customers from seeing sensitive staff data
REVOKE SELECT ON final_shafaye_salon.staff FROM 'salon_customer'@'localhost';
GRANT SELECT (staff_id, user_id, position, status) ON final_shafaye_salon.staff 
TO 'salon_customer'@'localhost';

-- Prevent customers from seeing other users' personal data
-- (This is enforced through application logic using LoggedInUserID)

-- ==========================================
-- CONNECTION EXAMPLES
-- ==========================================

-- Admin connection (full system management)
-- mysql -u salon_admin -p

-- Staff connection (read-only dashboard views)
-- mysql -u salon_staff -p  

-- Customer connection (booking and profile management)
-- mysql -u salon_customer -p

-- Web application connection (backend operations)
-- mysql -u salon_webapp -p

-- ==========================================
-- USER MANAGEMENT
-- ==========================================

-- Change passwords
-- ALTER USER 'salon_admin'@'localhost' IDENTIFIED BY 'NewAdminPass!';
-- ALTER USER 'salon_staff'@'localhost' IDENTIFIED BY 'NewStaffPass!';
-- ALTER USER 'salon_customer'@'localhost' IDENTIFIED BY 'NewCustomerPass!';

-- Add new permissions (example)
-- GRANT INSERT ON final_shafaye_salon.some_table TO 'salon_customer'@'localhost';

-- Remove permissions (example)  
-- REVOKE INSERT ON final_shafaye_salon.some_table FROM 'salon_customer'@'localhost';

-- Final refresh
FLUSH PRIVILEGES;

-- ==========================================
-- REMOTE ACCESS SETUP (if needed)
-- ==========================================

-- For hosting on separate web server
-- CREATE USER 'salon_webapp'@'%' IDENTIFIED BY 'RemoteWebApp2025!';
-- GRANT SELECT, INSERT, UPDATE, DELETE ON final_shafaye_salon.* TO 'salon_webapp'@'%';

-- For specific server IP (more secure)
-- CREATE USER 'salon_webapp'@'192.168.1.100' IDENTIFIED BY 'RemoteApp2025!';
-- GRANT SELECT, INSERT, UPDATE, DELETE ON final_shafaye_salon.* TO 'salon_webapp'@'192.168.1.100';

-- ==========================================
-- CLEANUP COMMANDS (use when needed)
-- ==========================================

-- DROP USER 'salon_admin'@'localhost';
-- DROP USER 'salon_staff'@'localhost';  
-- DROP USER 'salon_customer'@'localhost';
-- DROP USER 'salon_webapp'@'localhost';

ALTER USER 'salon_webapp'@'localhost' IDENTIFIED BY 'WebApp2025!';
FLUSH PRIVILEGES;

SHOW GRANTS FOR 'salon_customer'@'localhost';
SHOW GRANTS FOR 'salon_staff'@'localhost';

GRANT USAGE ON final_shafaye_salon.* TO 'salon_staff'@'localhost';
GRANT USAGE ON final_shafaye_salon.* TO 'salon_customer'@'localhost';