from django.db import models

# Create your models here.
class Job(models.Model):
    # Images
    image = models.ImageField(upload_to='images/')
    # summary
    sumamry = models.CharField(max_length=200)