using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly TestimonialManager _testimonialManager;

        public TestimonialManager(TestimonialManager testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialManager.TDelete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialManager.TGetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialManager.TGetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialManager.TInsert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialManager.TUpdate(t);
        }
    }
}
