#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

struct Node
{
	int data;
	struct Node* next;
};

struct Node* top = NULL;

void push(int value) 
{
	Node* temp;
	temp = (struct Node*)malloc(sizeof(struct Node));
	if (temp == NULL)
	{
		printf("Переполнение стека!");
		exit(0);
	}
	else
	{
		temp->data = value;
		temp->next = top;
		top = temp;
	}
}

int isEmpty()
{
	return top == NULL;
}

int peek()
{
	if (!isEmpty())
	{
		return top->data;
	}
	else
	{
		exit(0);
	}
}

int size()
{
	struct Node* temp;
	temp = top;
	int i = 0;
	while (temp != NULL)
	{
		temp = temp->next;
		i++;
	}
	return i;
}

void pop()
{
	struct Node* temp;
	if (isEmpty())
	{
		printf("Переполнение стека!");
		exit(0);
	}
	else
	{
		temp = top;
		top = top->next;
		temp->next = NULL;
		free(temp);
	}
}

void show_all()
{
	Node* temp;
	if (isEmpty())
	{
		printf("Переполнение стека!");
		exit(1);
	}
	else
	{
		temp = top; int i = 0;
		while (temp != NULL)
		{
			printf("Элемент(%d): %d\n", i, temp->data);
			temp = temp->next;
			i++;
		}
		printf("\n");
	}
}

void reverse_stack()
{
	Node* temp;
	temp = top;
	int* buf = (int*)malloc(sizeof(int) * size());
	if (!isEmpty())
	{
		for (int i = 0; i < size(); i++)
		{
			buf[i] = temp->data;
			temp = temp->next;
		}

		for (int i = 0; i < size() / 2; i++)
		{
			buf[i] = buf[i] + buf[size() - i - 1]; 
			buf[size() - i - 1] = buf[i] - buf[size() - i - 1];
			buf[i] = buf[i] - buf[size() - i - 1];
		}
		top->data = buf[size() - 1];
		for (int i = 0; i < size(); i++)
		{
			printf("Элемент(%d): %d\n", i, buf[i]);
		}
	}

	else
	{
		perror("Переполнение стека!\n");
		exit(0);
	}
}

int main()
{
	system("chcp 1251");
	printf("Стек:\n");
	push(1);
	push(2);
	push(3);
	push(4);
	push(5);
	show_all();
	printf("Размер стека: %d\n\n", size());
	printf("Обратный стек: \n");
	reverse_stack();
	return 0;
}