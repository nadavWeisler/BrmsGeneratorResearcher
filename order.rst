Experiment Order
==================

Each note has block and sub block.

blocks and sub blocks are the way for us to order and randomize trials in our experiment.

If trial is with block number 0,
its means that the trials stay fixed in his defined place.

Else, each block number trial groups switch with other block number trial group. Same rules applied on sub blocks.

For example: lets look at an random experiment.

+---------------+-------+-----------+
| Name          | Block | Sub Block |
+===============+=======+===========+
| Instructions0 | 0     | 0         |
+---------------+-------+-----------+
| bRMS1         | 1     | 1         |
+---------------+-------+-----------+
| Instructions1 | 1     | 0         |
+---------------+-------+-----------+
| Survey1       | 1     | 1         |
+---------------+-------+-----------+
| bRMS2         | 2     | 1         |
+---------------+-------+-----------+
| Instructions2 | 2     | 0         |
+---------------+-------+-----------+
| Survey2       | 2     | 1         |
+---------------+-------+-----------+

Than the experiment will be:

+-----------------------------------------------+
| Instructions0                                 |
+-----------------------------------------------+
| bRMS1/2                                       |
+-----------------------------------------------+
| Instructions1/2                               |
+-----------------------------------------------+
| Survey1/2                                     |
+-----------------------------------------------+
| bRMS1/2 (other than the first one)            |
+-----------------------------------------------+
| Instructions1/2 (other than the first one)    |
+-----------------------------------------------+
| Survey1/2 (other than the first one)          |
+-----------------------------------------------+