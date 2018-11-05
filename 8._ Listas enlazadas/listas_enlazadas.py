class node:
    def __init__(self, data = None, next = None):
        self.data = data
        self.next = next


class linked_list:
    def __init__(self):
        self.head = None

def add_at_end(self, data):
    if not self.head:
        self.head = node(data=data)
        return
    curr = self.next
    while curr.next:
        curr = curr.next
        curr.next = node(data-data)

temp = node(10)
print temp
