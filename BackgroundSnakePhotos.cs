using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class BackgroundSnakePhotos
    {

        public string GetRandomPhoto()
        {
            var random = new Random();
            var photoList = new List<string> 
            {   
                "https://cdn.pixabay.com/photo/2020/02/25/11/05/snake-4878609_960_720.jpg",
                "https://cdn.pixabay.com/photo/2020/07/14/22/06/snake-5405862_960_720.jpg",
                "https://cdn.pixabay.com/photo/2016/06/20/14/05/snake-1468932_960_720.jpg",
                "https://cdn.pixabay.com/photo/2014/10/16/10/38/snake-490952_960_720.jpg",
                "https://cdn.pixabay.com/photo/2018/04/06/11/49/snake-3295605_960_720.jpg",
                "https://cdn.pixabay.com/photo/2016/12/08/17/32/rattlesnake-1892417_960_720.jpg",
                "https://cdn.pixabay.com/photo/2018/01/06/10/49/snake-3064737_960_720.jpg",
                "https://cdn.pixabay.com/photo/2019/05/14/09/58/snake-4201970_960_720.jpg",
                "https://cdn.pixabay.com/photo/2017/01/06/15/38/python-1958052_960_720.jpg"
            };
            int index = random.Next(photoList.Count);
            string snakePhoto = photoList[index];
            return snakePhoto;
        }

    }
}
