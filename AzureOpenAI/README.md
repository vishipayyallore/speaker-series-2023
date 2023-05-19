# learn-azure-openai-2023

I am learning Azure OpenAI from different books, websites, and video courses.

**Reference(s):**

> 1. [https://jupyter.org/install](https://jupyter.org/install)

## Creating Python Virtual Environment

```bash
python -m venv ./pvenv

PS C:\LordKrishna\GitHub\learn-azure-openai-2023> .\pvenv\Scripts\activate

pip list
pip freeze > requirements.txt
pip install -r requirements.txt

(pvenv) PS C:\LordKrishna\GitHub\learn-azure-openai-2023> deactivate
```

## Topics for Sessions

> 1. First Session => Tokens / Max Tokens / Temperature / Top P / Frequency Penalty / Presence Penalty / Stop Sequence / Echo / N. Rest API, Python, C#
> 1. Desired Output Format
> 1. Summirize the data
> 1. Data Extraction

## Jupyter Lab / Notebook

```bash
pip install jupyterlab
jupyter-lab

pip install notebook
jupyter notebook
```

Inputs:

```text
Input: Give the top 5 food items from South India

Desired Format:
JSON include name, description fields only

Answer:
```

```text
Input: Give the top 5 Populated states in India

Desired Format:
JSON include name, count, description fields only

Answer:
```

```text
Input: Give the top 5 Populated states in India

Desired Format:
JSON Object with state name as key and count as value

Answer:
```
