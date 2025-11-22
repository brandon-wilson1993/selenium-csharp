Using this as a test bed to build a Selenium framework from scratch. 

My intention is to use a test site for the time being until I have created an application with a UI.



The repo contains a dll (called Sulfur) which is a wrapper around Selenium calls to make it easier to use within the tests. The WebDriver has been implemented as a singleton to force only one instance of the driver to be usable. This is handled in Sulfur so the test repo is not responsible for this code. In a real world scenario, this would most likely be a separate repo entirely. I have kept it together for ease of use.


The "test repo" in this case is located in SeleniumSharp. The tests are using this website for testing: https://www.tutorialspoint.com/selenium/practice/text-box.php. 
