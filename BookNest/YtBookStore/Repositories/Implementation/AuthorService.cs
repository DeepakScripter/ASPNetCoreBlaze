﻿using System;
using System.Collections.Generic;
using System.Linq;
using YtBookStore.Models.Domain;
using YtBookStore.Repositories.Abstract;

namespace YtBookStore.Repositories.Implementation
{
    // Implementation of the IAuthorService interface
    public class AuthorService : IAuthorService
    {
        private readonly DatabaseContext context;

        // Constructor injection of DatabaseContext
        public AuthorService(DatabaseContext context)
        {
            this.context = context;
        }

        // Method to add an author
        public bool Add(Author model)
        {
            try
            {
                context.Author.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }
        }

        // Method to delete an author by ID
        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Author.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }
        }

        // Method to find an author by ID
        public Author FindById(int id)
        {
            return context.Author.Find(id);
        }

        // Method to get all authors
        public IEnumerable<Author> GetAll()
        {
            return context.Author.ToList();
        }

        // Method to update an author
        public bool Update(Author model)
        {
            try
            {
                context.Author.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }
        }
    }
}
