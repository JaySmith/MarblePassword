﻿using Magrathea.Data;
using System;
using System.IO;

namespace MarblePassword.Win.Services
{
    class PasswordDatabaseRepository
    {
        private string _filename;
        private FileDataRepository _dataService;

        public PasswordDatabaseRepository(string filename)
        {
            _filename = filename;

            //if (File.Exists(filename))
            //{
                _dataService = new FileDataRepository(filename);
            //}

        }

        public PasswordDatabase Read()
        {
            return _dataService.Read<PasswordDatabase>();
        }
        
        public void Save(PasswordDatabase data)
        {
            data.Modified = DateTime.Now;
            _dataService.Save<PasswordDatabase>(data);
        }

    }
}
