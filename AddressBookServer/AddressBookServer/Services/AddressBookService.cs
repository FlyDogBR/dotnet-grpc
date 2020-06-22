namespace AddressBookServer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;

    public class AddressBookService : Address.AddressBase
    {
        private readonly List<Person> _people;

        public AddressBookService()
        {
            this._people = new List<Person>();

            Person person1 = new Person
            {
                Id = 1,
                Name = "John Doe",
                Email = "jdoe@example.com",
                Phones = { new Person.Types.PhoneNumber { Number = "555-1111", Type = Person.Types.PhoneType.Home } },
                LastUpdated = Timestamp.FromDateTimeOffset(new DateTimeOffset(DateTime.Now)),
                Duration = Duration.FromTimeSpan(new TimeSpan(2342341L)),
                DoubleTestNullType = -1.002305d,
                FloaTestNullType = -5.0005f,
                Int32TestNullType = -153,
                Int64TestNullType = -324234234,
                StringTestNullType = ""
            };

            Person person2 = new Person
            {
                Id = 2,
                Name = "Paul",
                Email = "paul@example.com",
                Phones = { new Person.Types.PhoneNumber { Number = "555-2221", Type = Person.Types.PhoneType.Mobile },
                    new Person.Types.PhoneNumber { Number = "555-2222", Type = Person.Types.PhoneType.Work }},
                LastUpdated = Timestamp.FromDateTimeOffset(new DateTimeOffset(DateTime.Now)),
                Duration = Duration.FromTimeSpan(new TimeSpan(1234)),
                DoubleTestNullType = 1.002305d,
                FloaTestNullType = 5.0005f,
                Int32TestNullType = 153,
                Int64TestNullType = 324234234,
                StringTestNullType = "test"
            };

            Person person3 = new Person
            {
                Id = 3,
                Name = "Lauren",
                Email = "lauren@example.com",
                Phones = { new Person.Types.PhoneNumber { Number = "555-3331", Type = Person.Types.PhoneType.Work },
                    new Person.Types.PhoneNumber { Number = "555-3332", Type = Person.Types.PhoneType.Mobile },
                    new Person.Types.PhoneNumber { Number = "555-3333", Type = Person.Types.PhoneType.Home }},
                LastUpdated = Timestamp.FromDateTimeOffset(new DateTimeOffset(DateTime.Now)),
                Duration = Duration.FromTimeSpan(new TimeSpan(433)),
            };

            _people.Add(person1);
            _people.Add(person2);
            _people.Add(person3);

        }

        public override async Task<AddressBookResponse> Get(AddressBookRequest request, ServerCallContext context)
        {
            var listPerson = new List<Person>();

            if (string.IsNullOrWhiteSpace(request.Id))
            {
                listPerson.AddRange(this._people);
            }
            else
            {
                listPerson.Add(this._people.Single(x => x.Id == int.Parse(request.Id)));
            }

            var response = new AddressBookResponse()
            {
                People = { listPerson }
            };

            return await Task.FromResult(response);
        }
    }
}
